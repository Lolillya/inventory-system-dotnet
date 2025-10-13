import { InvoiceProductModel } from "@/models/invoice.model";
import { useQuery, useQueryClient } from "@tanstack/react-query";

const InvoiceProductKey = ["invoice-product"];

export const useSelectedProductInvoiceQuery = () => {
  return useQuery<InvoiceProductModel[]>({
    queryKey: InvoiceProductKey,
    queryFn: async () => {
      return [];
    },
    enabled: false,
  });
};

export const useSelectedInvoiceProduct = () => {
  const queryClient = useQueryClient();

  const addProduct = (product: InvoiceProductModel) => {
    queryClient.setQueryData<InvoiceProductModel[]>(
      InvoiceProductKey,
      (old = []) => {
        // Check if product already exists
        const exists = old.some(
          (p) =>
            p.item.invoice.product.product_ID ===
              product.item.invoice.product.product_ID &&
            p.item.invoice.variant.variantName ===
              product.item.invoice.variant.variantName
        );
        const next = exists ? old : [...old, product];
        // Log the updated selected invoices
        console.log("[selected-product] addProduct ->", next);
        return next;
      }
    );
  };

  // Update quantity by product id and optional variant name (matches UI usage)
  const updateInvoiceQuantityByKey = (
    productId: string | number,
    unit_quantity: number,
    variantName?: string
  ) => {
    queryClient.setQueryData<InvoiceProductModel[]>(
      InvoiceProductKey,
      (old = []) => {
        const idx = old.findIndex(
          (p) =>
            String(p.item.invoice.product.product_ID) === String(productId) &&
            (variantName
              ? p.item.invoice.variant.variantName === variantName
              : true)
        );
        if (idx === -1) return old;

        const target = old[idx];
        const updatedItem: InvoiceProductModel = {
          ...target,
          item: {
            ...target.item,
            unit_quantity,
            total:
              unit_quantity * target.item.unit_price - target.item.discount,
          },
        };
        const newArr = [...old];
        newArr[idx] = updatedItem;
        return newArr;
      }
    );
  };

  // Update unit price by product id and optional variant name
  const updateInvoiceUnitPriceByKey = (
    productId: string | number,
    unit_price: number,
    variantName?: string
  ) => {
    queryClient.setQueryData<InvoiceProductModel[]>(
      InvoiceProductKey,
      (old = []) => {
        const idx = old.findIndex(
          (p) =>
            String(p.item.invoice.product.product_ID) === String(productId) &&
            (variantName
              ? p.item.invoice.variant.variantName === variantName
              : true)
        );
        if (idx === -1) return old;

        const target = old[idx];
        const updatedItem: InvoiceProductModel = {
          ...target,
          item: {
            ...target.item,
            unit_price,
            total:
              target.item.unit_quantity * unit_price - target.item.discount,
          },
        };
        const newArr = [...old];
        newArr[idx] = updatedItem;
        console.log(
          "[selected-product] updateInvoiceUnitPriceByKey ->",
          newArr
        );
        return newArr;
      }
    );
  };

  const removeProduct = (product: InvoiceProductModel) => {
    queryClient.setQueryData<InvoiceProductModel[]>(
      InvoiceProductKey,
      (old = []) => {
        const next = old.filter(
          (p) =>
            !(
              p.item.invoice.product.product_ID ===
                product.item.invoice.product.product_ID &&
              p.item.invoice.variant.variantName ===
                product.item.invoice.variant.variantName
            )
        );
        console.log("[selected-product] removeProduct ->", next);
        return next;
      }
    );
  };

  const clearList = () => {
    queryClient.setQueryData<InvoiceProductModel[]>(InvoiceProductKey, []);
    console.log("[selected-product] clearList -> []");
  };

  return {
    addProduct,
    removeProduct,
    updateInvoiceQuantityByKey,
    updateInvoiceUnitPriceByKey,
    clearList,
  };
};
