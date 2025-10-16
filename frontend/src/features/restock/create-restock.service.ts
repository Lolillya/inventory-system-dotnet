import { handleError } from "@/helpers/error-handler.helper";
import { RestockModel } from "@/models/restock.model";
import { api } from "../api/API.service";
import { useSelectedRestockSupplier } from "./selected-supplier";
import { useAuth } from "@/context/use-auth";

import axios from "axios";

// Pure function that does not use hooks. Accepts supplierId and userId as arguments.
export const createRestock = async (
  payload: RestockModel[],
  supplierId?: string | number,
  userId?: string | number
) => {
  console.log("payload: ", payload);
  console.log("supplierId: ", supplierId, "userId:", userId);
  try {
    const dtos = payload.map((p) => ({
      LineItem: {
        Product_ID: p.restock.items.product.product_ID,
        Unit: p.restock.items.variant.variantName,
        SubTotal: p.restock.total,
        Quantity: p.restock.unit_quantity,
      },
      Batch: {
        Batch_Number: 1,
        Supplier_ID: supplierId,
      },
      Restock_Clerk: userId,
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

// Hook wrapper that binds hooks and returns a safe caller for components
export const useCreateRestock = () => {
  const { data: supplier } = useSelectedRestockSupplier();
  const { user } = useAuth();

  const call = async (payload: RestockModel[]) => {
    return createRestock(payload, supplier?.id, user?.user_ID);
  };

  return { createRestock: call };
};
