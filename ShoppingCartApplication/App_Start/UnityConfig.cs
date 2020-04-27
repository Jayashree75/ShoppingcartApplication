namespace ShoppingCartApplication
{
  using BusinessLayer.Interfaces;
  using BusinessLayer.Services;
  using RepositoryLayer.Interfaces;
  using RepositoryLayer.Services;
  using System.Web.Mvc;
  using Unity;
  using Unity.Mvc5;


  public static class UnityConfig
  {
    public static void RegisterComponents()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();
      container.RegisterType<IProductBL, ProductBL>();
      container.RegisterType<IProductRL, ProductRL>();
      DependencyResolver.SetResolver(new UnityDependencyResolver(container));
    }
  }
}