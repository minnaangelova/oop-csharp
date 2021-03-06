﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {

            this.OrderItemId = orderItemId;
        }

        public int OrderItemId
        {
            get;
            set;
        }

        public int OrderQuantity
        {
            get;
            set;
        }

        public int ProductId
        {
            get;
            set;
        }

        public decimal? PurchasePrice
        {
            get;
            set;
        }

        //Retrieve one order item
        public OrderItem Retrieve(int prderItedId)
        {
            //Code that retrieves the defined order item
            return new OrderItem();
        }

        //Saves the current order item
        public bool Save()
        {
            return true;
        }

        //Validates the order item data
        public bool Validate()
        {
            var isValid = true;

            if(OrderQuantity<=0)
            {
                isValid = false;
            }
            if(ProductId<=0)
            {
                isValid = false;
            }
            if(PurchasePrice==null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
