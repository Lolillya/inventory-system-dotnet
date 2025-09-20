import { InventoryProductModel } from "@/models/inventory.model";
import { useQuery, useQueryClient } from "@tanstack/react-query";

const InvoiceProductKey = ["invoice-product"];

export const useSelectedProductInvoiceQuery = () => {
  return useQuery<InventoryProductModel | null>({
    queryKey: InvoiceProductKey,
    queryFn: async () => {
      return null;
    },
    enabled: false,
  });
};

export const useSelectedInvoiceProduct = () => {
  const queryClient = useQueryClient();

  return (product: InventoryProductModel | null) => {
    queryClient.setQueryData<InventoryProductModel | null>(InvoiceProductKey, product);
  };
};
