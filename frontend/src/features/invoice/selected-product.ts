import { InventoryProductModel } from "@/models/inventory.model";
import { useQuery, useQueryClient } from "@tanstack/react-query";

const InvoiceProductKey = ["invoice-product"];

export const useSelectedProductInvoiceQuery = () => {
  return useQuery<InventoryProductModel[]>({
    queryKey: InvoiceProductKey,
    queryFn: async () => {
      return [];
    },
    enabled: false,
  });
};

export const useSelectedInvoiceProduct = () => {
  const queryClient = useQueryClient();

  const addProduct = (product: InventoryProductModel) => {
    queryClient.setQueryData<InventoryProductModel[]>(InvoiceProductKey, (old = []) => {
      // Check if product already exists
      const exists = old.some(p => 
        p.product.product_ID === product.product.product_ID && 
        p.variant.variantName === product.variant.variantName
      );
      return exists ? old : [...old, product];
    });
  };

  const removeProduct = (product: InventoryProductModel) => {
    queryClient.setQueryData<InventoryProductModel[]>(InvoiceProductKey, (old = []) => 
      old.filter(p => 
        !(p.product.product_ID === product.product.product_ID && 
          p.variant.variantName === product.variant.variantName)
      )
    );
  };

  return { addProduct, removeProduct };
};
