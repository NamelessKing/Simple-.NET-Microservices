﻿using System;

namespace Play.Inventory.Service
{
    public record GrantItemsDto(Guid UserId, Guid CatalogItemId, int Quantity);
    public record InventoryItemDto(Guid CatalogItemId, int Quantity, DateTimeOffset AcquaridDate);
    public record CatalogItemDto(Guid Id, string Name, string Description);
}