import { InventoryProductModel } from "./inventory.model";

export type InvoiceProductModel = {
    item: {
        invoice: InventoryProductModel;
        unit: units;
        unit_quantity: number;
        unit_price: number;
        discount: number;
        total: number;
    }
}

export enum units {
    NONE = "",
    BOXES = "BOXES",
    PACKS = "PACKS"
}