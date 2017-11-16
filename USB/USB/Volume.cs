namespace USB
{
    class Volume
    {
        private string _name;
        private long _freeSpace;
        private long _totalSpace;
        private long _usedSpace;

        public Volume(string name, long freeSpace, long totalSpace)
        {
            _name = name;
            _freeSpace = freeSpace;
            _totalSpace = totalSpace;
            _usedSpace = _totalSpace - _freeSpace;
        }

        public Volume(string name)
        {
            _name = name;
            _freeSpace = 0;
            _totalSpace = 0;
            _usedSpace = 0;
        }

        public string Name => _name;

        public long FreeSpace => _freeSpace;

        public long TotalSpace => _totalSpace;

        public long UsedSpace => _usedSpace;
    }
}
