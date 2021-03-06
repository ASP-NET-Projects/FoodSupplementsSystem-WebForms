﻿using FoodSupplementsSystem.Data.Models;
using FoodSupplementsSystem.Data.Services.Contracts;
using FoodSupplementsSystem.Web.App_Start;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace FoodSupplementsSystem.Web.Public
{
    public partial class ViewBrands : Page
    {
        private readonly IBrandsServices brandsServices;

        public ViewBrands()
        {
            this.brandsServices = NinjectWebCommon.Kernel.Get<IBrandsServices>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Brand> lvBrands_GetData()
        {
            return this.brandsServices.GetAll().OrderBy(x => x.Id);
        }
    }
}