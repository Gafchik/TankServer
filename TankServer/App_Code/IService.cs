using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Реструктуризация" можно использовать для одновременного изменения имени интерфейса "IService" в коде и файле конфигурации.
[ServiceContract]
public interface IService
{
    [OperationContract]
    void Reg(long ip ,float x,float y);
    [OperationContract]
    [ServiceKnownType(typeof(ServerTank))]
    List<ServerTank> GetList();
    [OperationContract]
    void Remuve(long ip);
    [OperationContract]
    void Go_UL(long ip);
    [OperationContract]
    void Go_U(long ip);
    [OperationContract]
    void Go_UR(long ip);
    [OperationContract]
    void Go_D(long ip);
    [OperationContract]
    void Go_DL(long ip);
    [OperationContract]
    void Go_DR(long ip);
    [OperationContract]
    void Go_L(long ip);
    [OperationContract]
    void Go_R(long ip);
   


}

// Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
[DataContract]
public class ServerTank
{
    public ServerTank()
    {
        _speed = 7;
    }

    [DataMember] public long ip { get; set; }
	[DataMember] public float x { get; set; }
	[DataMember] public float y { get; set; }
    [DataMember] public float _speed  { get; set; }
    #region методы перемещения
    public void Go_U() // вверх
    {       
        y -= _speed;               
    }
    public void Go_UL() // вверх лево
    {
         
        y -= _speed;
        x -= _speed;
    }
    public void Go_UR() // вверх право
    {         
        y -= _speed;
       x += _speed;

    }
    public void Go_D()  // вниз
    {        
        y += _speed;;
    }
    public void Go_DL()  // вниз лево
    {        
        y += _speed;
       x -= _speed;
    }
    public void Go_DR()  // вниз право
    {        
        y += _speed;
       x += _speed;
    }
    public void Go_L() // в лево
    {        
       x -= _speed;
    }
    public void Go_R() // в право
    {        
       x += _speed;
    }
    #endregion

}
[CollectionDataContract]
[KnownType(typeof(ServerTank))]
public class ServerTankCollection : List<ServerTank>
{
    public List<ServerTank> list;

    public ServerTankCollection(List<ServerTank> list)
    {
        list.ForEach(i => this.Add(i));
        
    }
}

