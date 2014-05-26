﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nPOSProj.VO
{
    class ItemVO
    {
        private Int32 _item_id;
        private String _stock_code;
        private String _item_ean;
        private Int32 _item_quantity;
        private Double _item_retail_price;
        private Double _item_whole_price;
        private Int32 _is_kit;
        private String _kit_name;
        private DAO.ItemsDAO items;

        public ItemVO() { }

        public Int32 item_id
        {
            get { return _item_id; }
            set { _item_id = value; }
        }
        public String stock_code
        {
            get { return _stock_code; }
            set { _stock_code = value; }
        }
        public String item_ean
        {
            get { return _item_ean; }
            set { _item_ean = value; }
        }
        public Int32 item_quantity
        {
            get { return _item_quantity; }
            set { _item_quantity = value; }
        }
        public Double item_retail_price
        {
            get { return _item_retail_price; }
            set { _item_retail_price = value; }
        }
        public Double item_whole_price
        {
            get { return _item_whole_price; }
            set { _item_whole_price = value; }
        }
        public Int32 is_kit
        {
            get { return _is_kit; }
            set { _is_kit = value; }
        }
        public String kit_name
        {
            get { return _kit_name; }
            set { _kit_name = value; }
        }

        public void UpdateItem()
        {
            items = new DAO.ItemsDAO();
            items.Update(item_quantity, item_ean, item_retail_price, item_whole_price, stock_code);
        }
        public void TrasferItemToStock()
        {
            items = new DAO.ItemsDAO();
            items.ReturnToStocks(item_quantity, stock_code);
        }
        public void TrasferStockToItem()
        {
            items = new DAO.ItemsDAO();
            items.SendToItem(item_quantity, stock_code);
        }
        public String askKitName()
        {
            String Kit;
            items = new DAO.ItemsDAO();
            items.pushKitName(item_ean);
            Kit = items.pushKitName(item_ean);
            return Kit;
        }
        public String askEAN()
        {
            String EAN;
            items = new DAO.ItemsDAO();
            items.pushEan(kit_name);
            EAN = items.pushEan(kit_name);
            return EAN;
        }
        #region Item Kits Objects
        public void PushKit()
        {
            items = new DAO.ItemsDAO();
            items.InsertKit(item_quantity, item_ean, stock_code);
        }
        public void PatchKit()
        {
            items = new DAO.ItemsDAO();
            items.UpdateKit(item_quantity, item_ean, stock_code);
        }
        public void PullKit()
        {
            items = new DAO.ItemsDAO();
            items.DeleteKit(item_ean, stock_code);
        }
        #endregion
    }
}