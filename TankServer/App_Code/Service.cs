using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] // мод для сервиса один сервис на всех клиентов 
public class Service : IService
{
    //
    public List<ServerTank> tanks = new List<ServerTank>();
    public List<ServerTank> GetList()
    {
        return tanks;
    }

    public async void Remuve(long ip)
    {
        await Task.Run(() =>
        {
            if (tanks.Exists(i => i.ip == ip))
            {
                tanks.Remove(tanks.Find(i => i.ip == ip));
            }
        });
    }
    public async void Go_D(long ip)
    {
        await Task.Run(() =>
        {
            if (tanks.Exists(i => i.ip == ip))
            {
                tanks.Find(i => i.ip == ip).Go_D();
            }
        });
    }

    public async void Go_DL(long ip)
    {
        await Task.Run(() =>
           {
               if (tanks.Exists(i => i.ip == ip))
               {
                   tanks.Find(i => i.ip == ip).Go_DL();
               }
           });
    }

    public async void Go_DR(long ip)
    {
        await Task.Run(() =>
           {
               if (tanks.Exists(i => i.ip == ip))
               {
                   tanks.Find(i => i.ip == ip).Go_DR();
               }
           });
    }

    public async void Go_L(long ip)
    {
        await Task.Run(() =>
           {
               if (tanks.Exists(i => i.ip == ip))
               {
                   tanks.Find(i => i.ip == ip).Go_L();
               }
           });
    }

    public async void Go_R(long ip)
    {
        await Task.Run(() =>
           {
               if (tanks.Exists(i => i.ip == ip))
               {
                   tanks.Find(i => i.ip == ip).Go_R();
               }
           });
    }

    public async void Go_U(long ip)
    {
        await Task.Run(() =>
           {
               if (tanks.Exists(i => i.ip == ip))
               {
                   tanks.Find(i => i.ip == ip).Go_U();
               }
           });
    }

    public async void Go_UL(long ip)
    {
        await Task.Run(() =>
           {
               if (tanks.Exists(i => i.ip == ip))
               {
                   tanks.Find(i => i.ip == ip).Go_UL();
               }
           });
    }

    public async void Go_UR(long ip)
    {
        await Task.Run(() =>
           {
               if (tanks.Exists(i => i.ip == ip))
               {
                   tanks.Find(i => i.ip == ip).Go_UR();
               }
           });
    }

    public async void Reg(long ip, float x, float y)
    {
        await Task.Run(() =>
           {
               if (tanks.Exists(i => i.ip == ip))
               {
                   tanks.Remove(tanks.Find(i => i.ip == ip));
               }
               tanks.Add(new ServerTank() { ip = ip, x = x, y = y });
           });
    }


}

