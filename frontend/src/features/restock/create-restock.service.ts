import { handleError } from "@/helpers/error-handler.helper";
import { RestockModel } from "@/models/restock.model";
import axios from "axios";
import { api } from "../api/API.service";

export const CreateRestock = async (payload: RestockModel[]) => {
  try {
    console.log("payload: ", payload);

    // Transform frontend RestockModel[] to backend RestockDTO[] shape
    // backend expects: { LineItem: { Product_ID, Unit, SubTotal, Quantity }, Batch: { Batch_Number, Supplier_ID }, Restock_Clerk, Notes }
    const dtos = payload.map((p) => ({
      LineItem: {
        Product_ID: p.restock.items.product.product_ID,
        Unit: p.restock.items.variant.variantName,
        SubTotal: p.restock.total,
        Quantity: p.restock.unit_quantity,
      },
      Batch: {
        Batch_Number: 1,
        Supplier_ID: "",
      },
      Restock_Clerk: "",
      Notes: "",
    }));

    const res = await axios.post(api + "restock/", dtos, {
      headers: { "Content-Type": "application/json" },
    });

    console.log("create restock response:", res.data);
    return res.data;
  } catch (e) {
    handleError(e);
  }
};
