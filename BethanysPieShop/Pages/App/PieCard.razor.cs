﻿using BethanysPieShop.Models.Entities;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Pages.App;

public partial class PieCard
{
    [Parameter]
    public Pie? Pie { get; set; }
}
