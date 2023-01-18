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
