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
          },
        };
        const newArr = [...old];
        newArr[idx] = updatedItem;
        return newArr;
      }
    );
  };

  // Update discount by product id and optional variant name
  const updateInvoiceDiscountByKey = (
    productId: string | number,
    discount: number,
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
            discount,
          },
        };
        const newArr = [...old];
        newArr[idx] = updatedItem;
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
        return next;
      }
    );
  };

  const clearList = () => {
    queryClient.setQueryData<InvoiceProductModel[]>(InvoiceProductKey, []);
  };

  return {
    addProduct,
    removeProduct,
    updateInvoiceQuantityByKey,
    updateInvoiceUnitPriceByKey,
    updateInvoiceDiscountByKey,
    clearList,
  };
};
