import { InventoryProductModel } from "@/models/inventory.model";

export const ProductCard = ({ product }: { product: InventoryProductModel }) => {
  return (
    <div className="flex flex-col gap-3">
      <div className="flex justify-between bg-gray-bg rounded-lg py-2 px-2 text-xs items-center">
        <div className="grid gap-3 items-center">
          <span>{product.product.productName}</span>
          <span>{product.brand.brandName}</span>
          <span>{product.variant.variantName}</span>
        </div>
        <span># batches</span>
      </div>
    </div>
  );
};
