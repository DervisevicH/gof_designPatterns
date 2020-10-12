using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class RestaurantFacade
    {
        private ISaladProvider _saladProvider;
        public RestaurantFacade()
        {
            _saladProvider =new SaladProvider();
        }
        public void GetChickenSalad() { _saladProvider.GetChickenSalad(); }
        public void GetMexicanSalad() { _saladProvider.GetMexicanSalad(); }

    }
}
