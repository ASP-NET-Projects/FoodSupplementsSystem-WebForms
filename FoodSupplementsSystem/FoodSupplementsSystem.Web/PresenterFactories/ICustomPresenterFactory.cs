using System;
using WebFormsMvp;

namespace FoodSupplementsSystem.Web.PresenterFactories
{
    public interface ICustomPresenterFactory
    {
        IPresenter GetPresenter(Type presenterType, IView viewInstance);
    }
}