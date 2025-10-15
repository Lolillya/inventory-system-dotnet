import { RestockModel } from "@/models/restock.model";
import { useQuery, useQueryClient } from "@tanstack/react-query";

const RestockProductKey = ["restock-product"];

export const useSelectedRestockProduct = () => {
  return useQuery<RestockModel[]>({
    queryKey: RestockProductKey,
    queryFn: async () => {
      return [];
    },
    enabled: false,
  });
};

export const useSelectedRestock = () => {
  const queryClient = useQueryClient();

  const addProduct = (product: RestockModel) => {
    queryClient.setQueryData<RestockModel[]>(RestockProductKey, (old = []) => {
      // Check if product already exists
      const exists = old.some(
        (p) =>
          p.restock.items.product.product_ID ===
            product.restock.items.product.product_ID &&
          p.restock.items.variant.variantName ===
            product.restock.items.variant.variantName
      );
      const next = exists ? old : [...old, product];
      // Log the updated selected invoices
      console.log("[selected-product] addProduct ->", next);
      return next;
    });
  };

  const removeProduct = (product: RestockModel) => {
    queryClient.setQueryData<RestockModel[]>(RestockProductKey, (old = []) => {
      const next = old.filter(
        (p) =>
          !(
            p.restock.items.product.product_ID ===
              product.restock.items.product.product_ID &&
            p.restock.items.variant.variantName ===
              product.restock.items.variant.variantName
          )
      );
      console.log("[selected-product] removeProduct ->", next);
      return next;
    });
  };

  return {
    addProduct,
    removeProduct,
  };
};
