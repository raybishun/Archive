# How to enable SSH on Ubuntu 20.04
```
ip addr show

sudo apt update

sudo apt install openssh-server

sudo systemctl status ssh

sudo ufw status
sudo ufw allow ssh (if the UFW is enabled)
```