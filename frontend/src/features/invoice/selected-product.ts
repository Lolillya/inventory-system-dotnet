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

  const updateInvoice = (updated: InvoiceProductModel) => {
    queryClient.setQueryData<InvoiceProductModel[]>(
      InvoiceProductKey,
      (old = []) => {
        const next = old.map((p) => {
          const isSame =
            p.item.invoice.product.product_ID ===
              updated.item.invoice.product.product_ID &&
            p.item.invoice.variant.variantName ===
              updated.item.invoice.variant.variantName;

          if (!isSame) return p;

          const unit = updated.item.unit ?? p.item.unit;
          const unit_quantity =
            updated.item.unit_quantity ?? p.item.unit_quantity;
          const unit_price = updated.item.unit_price ?? p.item.unit_price;
          const discount = updated.item.discount ?? p.item.discount;

          const total =
            updated.item.total ?? unit_quantity * unit_price - discount;

          return {
            ...p,
            item: {
              ...p.item,
              unit,
              unit_quantity,
              unit_price,
              discount,
              total,
            },
          };
        });
        console.log("[selected-product] updateInvoice ->", next);
        return next;
      }
    );
  };

  // Update quantity by index (simpler, avoids matching issues)
  const updateInvoiceQuantity = (index: number, unit_quantity: number) => {
    queryClient.setQueryData<InvoiceProductModel[]>(
      InvoiceProductKey,
      (old = []) => {
        if (index < 0 || index >= old.length) return old;
        const target = old[index];
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
        newArr[index] = updatedItem;
        console.log("[selected-product] updateInvoiceQuantity ->", newArr);
        return newArr;
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
    updateInvoice,
    updateInvoiceQuantity,
    updateInvoiceQuantityByKey,
    clearList,
  };
};
