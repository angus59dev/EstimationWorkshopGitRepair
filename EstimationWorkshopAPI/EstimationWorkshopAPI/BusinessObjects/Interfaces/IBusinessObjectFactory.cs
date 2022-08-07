namespace EstimationWorkshopAPI.BusinessObjects.Interfaces;

public interface IBusinessObjectFactory<T>
{
    T Create();
}