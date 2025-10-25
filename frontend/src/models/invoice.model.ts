import { units } from "./enum";
import { InventoryProductModel } from "./inventory.model";

export type InvoiceProductModel = {
  invoice: {
    item: InventoryProductModel;
    unit: units;
    unit_quantity: number;
    unit_price: number;
    discount: number;
    total: number;
  };
};
