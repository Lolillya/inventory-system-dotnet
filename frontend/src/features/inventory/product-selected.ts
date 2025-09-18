import { useQuery, useQueryClient } from "@tanstack/react-query";
import { InventoryProductModel } from "../../models/inventory.model";

const ProductSelectedKey = ["product-selected"];

export const useSelectedProductQuery = () => {
  return useQuery<InventoryProductModel | null>({
    queryKey: ProductSelectedKey,
    queryFn: async () => {
      return null;
    },
    enabled: false,
  });
};

export const useSetSelectedProduct = () => {
  const queryClient = useQueryClient();

  return (product: InventoryProductModel | null) => {
    queryClient.setQueryData<InventoryProductModel | null>(ProductSelectedKey, product);
  };
};
