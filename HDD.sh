sudo hdparm -i /dev/sda |grep Model
df | awk '{size+=$2;  used+=$3; avial+=$4} END {print "Size " size "\n" "Used " used "\n" " Avial " avial}'
sudo hdparm -i /dev/sda |grep ATA
sudo hdparm -i /dev/sda |grep PIO
sudo hdparm -i /dev/sda |grep DMA