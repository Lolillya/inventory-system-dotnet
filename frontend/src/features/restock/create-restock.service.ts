import { handleError } from "@/helpers/error-handler.helper";
import { RestockModel } from "@/models/restock.model";
import { api } from "../api/API.service";
import { useSelectedRestockSupplier } from "./selected-supplier";
import { useAuth } from "@/context/use-auth";

import axios from "axios";

export const CreateRestock = async (payload: RestockModel[]) => {
  const { data: supplier } = useSelectedRestockSupplier();
  const { user } = useAuth();
  console.log("payload: ", payload);
  console.log("current user: ", user);
  try {
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
        Supplier_ID: supplier?.id,
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
