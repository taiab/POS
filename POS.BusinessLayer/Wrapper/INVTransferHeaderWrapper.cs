﻿using POS.BusinessLayer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BusinessLayer.Wrapper
{
    public class INVTransferHeaderWrapper : INVTransferHeaderService
    {
        private INVInventoryService invinventoryService = new INVInventoryService();

        private ADUserService aduserService = new ADUserService();

        public List<INVTransferHeaderModel> getAllTransferTransaction()
        {
            List<INVTransferHeaderModel> resultList = new List<INVTransferHeaderModel>();
            try
            {
                resultList = (from item in SelectAll()
                              join fromInv in invinventoryService.SelectAll() on item.FromInventoryID equals fromInv.InventoryID
                              join toInv in invinventoryService.SelectAll() on item.ToInventoryID equals toInv.InventoryID
                              join usr in aduserService.SelectAll() on item.CreatedBy equals usr.UserID
                              select new INVTransferHeaderModel()
                              {
                                  INVTransferHeaderID = item.INVTransferHeaderID.Value,
                                  CreatedBy = usr.UserName,
                                  FromInventory = fromInv.InventoryName,
                                  ToInventory = toInv.InventoryName,
                                  TransferDate = item.CreateDate.Value.Date.ToShortDateString()
                              }
                                  ).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultList;
        }

        public List<INVTransferHeaderModel> getAllTransferTransaction(INVTransferHeader invtransferHeader)
        {
            List<INVTransferHeaderModel> resultList = new List<INVTransferHeaderModel>();
            try
            {
                DateTime fromCreationDate = invtransferHeader.CreateDate.Value.Date.AddDays(-1);
                DateTime toCreationDate = invtransferHeader.CreateDate.Value.Date.AddDays(1);

                resultList = (from item in SelectAll()
                              join fromInv in invinventoryService.SelectAll() on item.FromInventoryID equals fromInv.InventoryID
                              join toInv in invinventoryService.SelectAll() on item.ToInventoryID equals toInv.InventoryID
                              join usr in aduserService.SelectAll() on item.CreatedBy equals usr.UserID
                              where (
                              (!invtransferHeader.FromInventoryID.HasValue || item.FromInventoryID == invtransferHeader.FromInventoryID)
                              && (!invtransferHeader.ToInventoryID.HasValue || item.ToInventoryID == invtransferHeader.ToInventoryID)
                              && (!invtransferHeader.CreateDate.HasValue || (item.CreateDate > fromCreationDate && item.CreateDate > toCreationDate))
                              )
                              select new INVTransferHeaderModel()
                              {
                                  INVTransferHeaderID = item.INVTransferHeaderID.Value,
                                  CreatedBy = usr.UserName,
                                  FromInventory = fromInv.InventoryName,
                                  ToInventory = toInv.InventoryName,
                                  TransferDate = item.CreateDate.Value.Date.ToShortDateString()
                              }
                                  ).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultList;
        }

        /////

        public bool SaveTransferOrder(INVTransferHeader transferHeader, INVTransferLineCollection sALSalesLineCollection)
        {
            POS.DataLayer.INVTransferHeader _transferHeader = new POS.DataLayer.INVTransferHeader();
            _transferHeader.TransferDate = DateTime.Now;
            _transferHeader.FromInventoryID = transferHeader.FromInventoryID;
            _transferHeader.ToInventoryID = transferHeader.ToInventoryID;
            //_transferHeader.IsClosed = false;
            _transferHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _transferHeader.CreateDate = DateTime.Now;
            _transferHeader.UpdatedBy = null;
            //_transferHeader.UpdateDate = null;
            _transferHeader.IsDeleted = false;
            _transferHeader.DeletedBy = null;
            _transferHeader.DeletedDate = null;

            POS.DataLayer.INVTransferLineCollection _sALSalesLineCollection = new DataLayer.INVTransferLineCollection();
            foreach (INVTransferLine sALSalesLine in sALSalesLineCollection)
            {
                POS.DataLayer.INVTransferLine _sALSalesLine = new POS.DataLayer.INVTransferLine();
                _sALSalesLine.ProductID = sALSalesLine.ProductID;
                _sALSalesLine.Qty = sALSalesLine.Qty;
                _sALSalesLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _sALSalesLine.CreateDate = DateTime.Now;
                _sALSalesLine.UpdatedBy = null;
                //_sALSalesLine.UpdateDate = null;
                _sALSalesLine.IsDeleted = false;
                _sALSalesLine.DeletedBy = null;
                _sALSalesLine.DeletedDate = null;
                _sALSalesLineCollection.Add(_sALSalesLine);
            }
            POS.DataLayer.INVTransferLine transferLineObj = new DataLayer.INVTransferLine();
            return transferLineObj.SaveTransaction(_transferHeader, _sALSalesLineCollection);
        }
        public bool SaveCloseTransferOrder(INVTransferHeader transferHeader, INVTransferLineCollection sALSalesLineCollection)
        {
            POS.DataLayer.INVTransferHeader _transferHeader = new POS.DataLayer.INVTransferHeader();

            _transferHeader.TransferDate = DateTime.Now;
            _transferHeader.FromInventoryID = transferHeader.FromInventoryID;
            _transferHeader.ToInventoryID = transferHeader.ToInventoryID;
            //_transferHeader.IsClosed = false;
            _transferHeader.CreatedBy = GlobalVariables.CurrentUser.UserID;
            _transferHeader.CreateDate = DateTime.Now;
            _transferHeader.UpdatedBy = null;
            //_transferHeader.UpdateDate = null;
            _transferHeader.IsDeleted = false;
            _transferHeader.DeletedBy = null;
            _transferHeader.DeletedDate = null;

            POS.DataLayer.INVTransferLineCollection _sALSalesLineCollection = new DataLayer.INVTransferLineCollection();
            foreach (INVTransferLine sALSalesLine in sALSalesLineCollection)
            {
                POS.DataLayer.INVTransferLine _sALSalesLine = new POS.DataLayer.INVTransferLine();
                _sALSalesLine.ProductID = sALSalesLine.ProductID;
                _sALSalesLine.Qty = sALSalesLine.Qty;
                _sALSalesLine.CreatedBy = GlobalVariables.CurrentUser.UserID;
                _sALSalesLine.CreateDate = DateTime.Now;
                _sALSalesLine.UpdatedBy = null;
                //_sALSalesLine.UpdateDate = null;
                _sALSalesLine.IsDeleted = false;
                _sALSalesLine.DeletedBy = null;
                _sALSalesLine.DeletedDate = null;
                _sALSalesLineCollection.Add(_sALSalesLine);
            }
            POS.DataLayer.INVTransferLine transferLineObj = new DataLayer.INVTransferLine();
            return transferLineObj.SaveTransaction(_transferHeader, _sALSalesLineCollection);
        }



    }

    public class INVTransferHeaderModel
    {
        public int INVTransferHeaderID { get; set; }
        public string TransferDate { get; set; }
        public string FromInventory { get; set; }
        public string ToInventory { get; set; }
        public string CreatedBy { get; set; }
    }
}
