﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Com.Efrata.Service.Sales.Lib.BusinessLogic.Interface;
using Com.Efrata.Service.Sales.Lib.Models;
using Com.Efrata.Service.Sales.Lib.Services;
using Com.Efrata.Service.Sales.Lib.ViewModels.CostCalculationGarment;
using Com.Efrata.Service.Sales.WebApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Com.Efrata.Service.Sales.WebApi.Controllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/rates")]
    [Authorize]
    public class RatesController : BaseController<Rate, RateViewModel, IRate>
    {
        private readonly static string apiVersion = "1.0";
        private readonly IIdentityService Service;
        public RatesController(IIdentityService identityService, IValidateService validateService, IRate facade, IMapper mapper, IServiceProvider serviceProvider) : base(identityService, validateService, facade, mapper, apiVersion)
        {
            Service = identityService;
        }
    }
}