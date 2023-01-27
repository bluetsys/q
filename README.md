# q

$$ x = {{BothAB} \over \sqrt{(onlyA+BothAB) * (onlyB+BothAB)}} $$


$$
\vec{\nabla} \times \vec{F} =
            \left( \frac{\partial F_z}{\partial y} - \frac{\partial F_y}{\partial z} \right) \mathbf{i}
          + \left( \frac{\partial F_x}{\partial z} - \frac{\partial F_z}{\partial x} \right) \mathbf{j}
          + \left( \frac{\partial F_y}{\partial x} - \frac{\partial F_x}{\partial y} \right) \mathbf{k}
$$

```
wget https://cdn.geekbench.com/Geekbench-5.4.6-Linux.tar.gz
tar xf Geekbench-5.4.6-Linux.tar.gz
cd Geekbench-5.4.6-Linux/
./geekbench5
```

```
sudo wget https://dot.net/v1/dotnet-install.sh
sudo chmod u+x ./dotnet-install.sh
sudo ./dotnet-install.sh -Channel 7.0 -Version latest
sudo cp -r $HOME/.dotnet/. /usr/lib/dotnet/.
sudo rm -rf $HOME/.dotnet
```

```
sudo ./dotnet-install.sh -Channel 7.0 -Version latest
sudo ./dotnet-install.sh -Channel 6.0 -Version latest
sudo ./dotnet-install.sh -Channel 5.0 -Version latest
sudo ./dotnet-install.sh -Channel 3.1 -Version latest
sudo ./dotnet-install.sh -Channel 3.0 -Version latest
sudo ./dotnet-install.sh -Channel 2.2 -Version latest
sudo ./dotnet-install.sh -Channel 2.1 -Version latest
sudo ./dotnet-install.sh -Channel 2.0 -Version latest

sudo cp -r /root/.dotnet/. /usr/lib/dotnet/.
sudo rm -rf /root/.dotnet
```


```
dotnet --list-sdks
dotnet --list-runtimes
```


```
sudo apt install cockpit cockpit-pcp
sudo nano /etc/netplan/01-netplan.yaml
```

```
network:
  renderer: NetworkManager
```

```
sudo apt install neofetch
```


```
wget -O- https://apt.repos.intel.com/intel-gpg-keys/GPG-PUB-KEY-INTEL-SW-PRODUCTS.PUB | gpg --dearmor | sudo tee /usr/share/keyrings/oneapi-archive-keyring.gpg > /dev/null
echo "deb [signed-by=/usr/share/keyrings/oneapi-archive-keyring.gpg] https://apt.repos.intel.com/oneapi all main" | sudo tee /etc/apt/sources.list.d/oneAPI.list
sudo apt update
sudo apt install intel-hpckit


sudo apt install -y nodejs gcc nasm pypy ruby golang kotlin swift nasm scala fpc lua5.2 gfortran gnucobol sqlite3 yabasic

```

```
wget https://julialang-s3.julialang.org/bin/linux/x64/1.8/julia-1.8.5-linux-x86_64.tar.gz
tar -xvzf julia-1.8.5-linux-x86_64.tar.gz
sudo cp -r julia-1.8.5 /opt/
sudo ln -s /opt/julia-1.8.3/bin/julia /usr/local/bin/julia
```

```
sudo apt install speedtest-cli
speedtest-cli
```

```
wget -O- https://aka.ms/install-vscode-server/setup.sh | sh
code-server
```

