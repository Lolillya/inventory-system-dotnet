import { useNavigate, useParams } from "react-router-dom";
import { useSelectedProductQuery } from "../../../../features/inventory/product-selected";
import { useEffect } from "react";
import { Separator } from "../../../../components/separator";
import { ProductDetails } from "./_components/product-details";
import { ProductVariantCard } from "./_components/product-variant-card";

export const EditProductPage = () => {
  //   const { id } = useParams<{ id: string }>();
  const { data: selectedProduct } = useSelectedProductQuery();
  const navigate = useNavigate();

  useEffect(() => {
    if (!selectedProduct) navigate(-1);
  }, []);

  return (
    <section>
      <div className="flex flex-col gap-10 flex-1">
        <div className="flex gap-3 border-b pb-5">
          <span>Edit Item</span>
          <span>{selectedProduct?.product.product_ID}</span>
        </div>
        {/* <Separator /> */}

        <div className="flex flex-col gap-10 flex-1">
          <ProductDetails />

          <ProductVariantCard />

          <div className="flex gap-5 justify-end">
            <button>clear</button>

            <button>save</button>
          </div>
        </div>
      </div>
    </section>
  );
};
