﻿using Laba9.Models;
namespace Laba9.ViewModels.HomeViewModels
{
    public enum ShowStyles
    {
        List,
        Table,
        Row
    }
    public record class ShowOrdersViewModel(IEnumerable<Order> Orders, ShowStyles ShowStyle);
}

