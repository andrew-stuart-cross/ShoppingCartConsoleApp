﻿using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    public static class StringHelpers
    {
        public static string BasketSummary(List<string> shoppingBasket)
        {
            return String.Format("Your shopping basket contains the following items: {0}", String.Join(", ", shoppingBasket));
        }

        public static string GrossSummary(string item, int quantity, decimal price)
        {
            if (quantity == 0)
            {
                return ($"There are no {item} in the basket");
            }
            else
            {
                return ($"{item}: {quantity} @ {price:C}.  The gross cost is { CheckoutHelpers.UpdateTotal(quantity, price):C} (before discounts are applied)");
            }

        }
    }
}