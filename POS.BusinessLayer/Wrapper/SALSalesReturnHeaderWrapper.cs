﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class SALSalesReturnHeaderWrapper : SALSalesReturnHeaderService
    {
        //VSalesReturnHeaderService vSalesReturnHeaderService;

        public VSalesReturnHeaderCollection SearchByCriteria(string CustomerName, string InvoiceNumber, DateTime DateFrom, DateTime DateTo)
        {
            VSalesReturnHeaderCollection vSalesReturnHeaderCollection = new VSalesReturnHeaderCollection();
            foreach (POS.DataLayer.VSalesReturnHeader _vSalesReturnHeader in POS.DataLayer.VSalesReturnHeader.SearchByriteria())
            {
                VSalesReturnHeader _vSalesReturnHeaderWCF = new VSalesReturnHeader();

                _vSalesReturnHeaderWCF.SlaesReturnHeaderID = _vSalesReturnHeader.SlaesReturnHeaderID;
                _vSalesReturnHeaderWCF.ReturnDate = _vSalesReturnHeader.ReturnDate;
                _vSalesReturnHeaderWCF.IsClosed = _vSalesReturnHeader.IsClosed;
                _vSalesReturnHeaderWCF.InvoiceNumber = _vSalesReturnHeader.InvoiceNumber;
                _vSalesReturnHeaderWCF.CustomerName = _vSalesReturnHeader.CustomerName;
                _vSalesReturnHeaderWCF.SalesHeaderID = _vSalesReturnHeader.SalesHeaderID;

                vSalesReturnHeaderCollection.Add(_vSalesReturnHeaderWCF);
            }
            return vSalesReturnHeaderCollection;
        }
        public bool DeleteOrder(int SalesReturnHeaderID)
        {
            return POS.DataLayer.SALSalesReturnHeader.DeleteOrder(SalesReturnHeaderID, Utility.GlobalVariables.CurrentUser.UserID);
        }

        public bool CloseOrder(int SalesReturnHeaderID)
        {
            return POS.DataLayer.SALSalesReturnHeader.CloseOrder(SalesReturnHeaderID, Utility.GlobalVariables.CurrentUser.UserID);

        }
    }
}
