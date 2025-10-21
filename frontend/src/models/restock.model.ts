import { units } from "./enum";
import { InventoryProductModel } from "./inventory.model";

export type RestockModel = {
  restock: {
    items: InventoryProductModel;
    unit: units;
    unit_quantity: number;
    unit_price: number;
    total: number;
  };
};
