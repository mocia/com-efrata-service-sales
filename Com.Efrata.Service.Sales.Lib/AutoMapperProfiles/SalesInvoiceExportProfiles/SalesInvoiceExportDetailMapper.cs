﻿using AutoMapper;
using Com.Efrata.Service.Sales.Lib.Models.SalesInvoiceExport;
using Com.Efrata.Service.Sales.Lib.ViewModels.SalesInvoiceExport;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Sales.Lib.AutoMapperProfiles.SalesInvoiceExportProfiles
{
    public class SalesInvoiceExportDetailMapper : Profile
    {
        public SalesInvoiceExportDetailMapper()
        {
            CreateMap<SalesInvoiceExportDetailModel, SalesInvoiceExportDetailViewModel>()

                .ReverseMap();
        }
    }
}
