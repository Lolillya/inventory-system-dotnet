import { NoSelectedState } from "@/components/no-selected-state";
import { UseInventoryQuery } from "@/features/inventory/get-inventory.query";
import {
  useSelectedProductInvoiceQuery,
  useSelectedInvoiceProduct,
} from "@/features/invoice/selected-product";
import { LeftArrowIcon, SearchIcon } from "@/icons";
import { useState } from "react";
import { ProductCard } from "../../../../components/product-card";
import { CreateRestockModal } from "./_components/restock-modal";

const NewRestockPage = () => {
  // GLOBAL STATES
  const { data: inventoryData, isLoading, error } = UseInventoryQuery();
  const { data: selectedInvoices = [] } = useSelectedProductInvoiceQuery();

  // LOCAL STATES
  const [isModalOpen, setIsModalOpen] = useState(false);

  // FETCH DATA LOADING STATE
  if (isLoading) return <div>Loading...</div>;
  // FETCHING DATA ERROR STATE
  if (error) return <div>Error...</div>;

  const createRestock = () => {
    setIsModalOpen((prev) => !prev);
  };

  return (
    <section>
      {isModalOpen && <CreateRestockModal createRestock={createRestock} />}
      <div className="flex flex-col min-h-0 flex-1 gap-5">
        <div className="flex flex-col gap-10">
          <div className="flex gap-3 border-b pb-5 items-center">
            <LeftArrowIcon />
            <span>new restock</span>
            <span>#123456</span>
            {/* <span>{selectedProduct?.product.product_ID}</span> */}
          </div>
          {/* <Separator /> */}
        </div>

        <div className="flex flex-col gap-10 overflow-y-hidden flex-1">
          <div className="flex gap-5 overflow-y-hidden flex-1">
            {/* LEFT */}
            <div className="w-full flex">
              {selectedInvoices.length === 0 ? (
                <NoSelectedState />
              ) : (
                <div className="flex gap-2 flex-wrap h-full overflow-y-auto flex-1 pr-2">
                  {/* {selectedInvoices.map((product, index) => (
                    <InvoiceCard
                      key={`${product.item.invoice.product.product_ID}-${product.item.invoice.variant.variantName}-${index}`}
                      product={product.item.invoice}
                      onRemove={() => removeProduct(product)}
                    />
                  ))} */}
                </div>
              )}
            </div>

            {/* RIGHT */}
            <div className="flex flex-col w-2/5 gap-5">
              <div className="rounded-lg shadow-lg p-5 border h-full overflow-y-hidden flex-1 flex flex-col gap-5">
                <div className="flex flex-col gap-1">
                  <div className="relative w-full">
                    <input placeholder="Search..." className="input-style-2" />
                    <i className="absolute left-3 top-1/2 -translate-y-1/2 text-gray-400">
                      <SearchIcon />
                    </i>
                  </div>
                </div>

                <div className="pr-2 flex flex-col gap-5 overflow-y-scroll flex-1 h-full">
                  {inventoryData?.map((data, i) => (
                    <ProductCard
                      product={data}
                      //   onClick={() => handleClick(data)}
                      key={i}
                    />
                  ))}
                </div>
              </div>

              <div className="flex gap-5 justify-between">
                <button>clear</button>
                <button onClick={createRestock}>create restock</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default NewRestockPage;
