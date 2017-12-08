using System;
using System.Collections.Generic;
using System.Linq;
using IMAPI2;

namespace CDBurn
{
    public class BurnManager
    {
        public delegate void UpdateBurnHandler(FormatWriteUpdateEventArgs e);
        public event UpdateBurnHandler UpdateBurn;

        private readonly ImageMaster _imageMaster = new ImageMaster();

        public List<DiscRecorder> RecordersList { get; }

        public BurnManager()
        {
            RecordersList = _imageMaster.Recorders.ToList();
            _imageMaster.FormatWriteUpdate += ImageMasterFormatWriteUpdate;
        }

        private void ImageMasterFormatWriteUpdate(ImageMaster sender, FormatWriteUpdateEventArgs e)
        {
            UpdateBurn?.Invoke(e);
        }

        public Disc GetDiscInfo(string[] recordersInfo)
        {
            try
            {
                _imageMaster.Recorders.SelectedIndex = _imageMaster.Recorders.ToList().FindIndex(x =>
                    x.VolumePath.Equals(recordersInfo[0]));
                _imageMaster.LoadRecorder();
                _imageMaster.LoadMedia();
                return new Disc()
                {
                    Type = _imageMaster.Media,
                    State = _imageMaster.MediaStates.Any(x => x == MediaState.Blank)
                        ? MediaState.Blank
                        : MediaState.Unknown,
                    Size = _imageMaster.MediaCapacity
                };
            }
            catch (Exception)
            {
                return new Disc()
                {
                    Type = PhysicalMedia.Unknown,
                    State = MediaState.Unknown,
                    Size = 0
                };
            }
        }

        public bool DiskIsAviable()
        {
            try
            {
                _imageMaster.LoadMedia();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SetFilesToBurning(List<FileNode> files)
        {
            _imageMaster.Nodes.Clear();
            _imageMaster.Nodes.AddRange(files);
        }

        public void Burn()
        {
            _imageMaster.WriteImage(BurnVerificationLevel.None, false, false);
        }

        public void Format()
        {
            _imageMaster.FormatMedia(false, false);
        }
    }
}
