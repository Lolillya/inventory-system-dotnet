export type InventoryProductModel = {
  product: {
    product_ID: number;
    productCode: string;
    productName: string;
    desc: string;
    brand_id: number;
    category_id: number;
    createdAt: string;
    updatedAt: string;
  };
  variant: {
    productId: number;
    variantName: string;
    createdAt: string;
    updatedAt: string;
  };
  brand: {
    brandName: string;
    createdAt: string;
    updatedAt: string;
  };
};
