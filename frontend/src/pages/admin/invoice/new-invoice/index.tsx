import { NoSelectedState } from "@/components/no-selected-state";
import { UseInventoryQuery } from "@/features/inventory/get-inventory.query";
import { HandshakeIcon, SearchIcon } from "@/icons";

const NewInvoicePage = () => {
  const { data: inventoryData, isLoading, error } = UseInventoryQuery();
  console.log(inventoryData);

  return (
    <section>
      <div className="flex flex-col min-h-0 flex-1 gap-5">
        <div className="flex flex-col gap-10">
          <div className="flex gap-3 border-b pb-5">
            <span>new invoice</span>
            <span>#123456</span>
            {/* <span>{selectedProduct?.product.product_ID}</span> */}
          </div>
          {/* <Separator /> */}
        </div>

        <div className="flex flex-col gap-10 overflow-y-hidden flex-1">
          <div className="flex gap-5 overflow-y-hidden flex-1">
            {/* LEFT */}
            <div className="w-full flex border rounded-lg shadow-lg">
              <NoSelectedState />
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
                  {/* {[...Array(20)].map((_, i) => (
                    <div className="flex flex-col gap-3" key={i}>
                      <div className="flex justify-between bg-gray-bg rounded-lg py-2 px-2 text-xs items-center">
                        <div className="flex gap-3 items-center">
                          <span>name</span>
                          <span>brand</span>
                          <span>variant</span>
                        </div>
                        <span># batches</span>
                      </div>
                    </div>
                  ))} */}
                  {inventoryData?.map((data, i) => (
                    <div className="flex flex-col gap-3" key={i}>
                      <div className="flex justify-between bg-gray-bg rounded-lg py-2 px-2 text-xs items-center">
                        <div className="flex gap-3 items-center">
                          <span>{data.product.productName}</span>
                          <span>{data.brand.brandName}</span>
                          <span>{data.variant.variantName}</span>
                        </div>
                        <span># batches</span>
                      </div>
                    </div>
                  ))}
                </div>
              </div>
              <div className="flex gap-5 justify-between">
                <button>clear</button>
                <button>create invoice</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default NewInvoicePage;
