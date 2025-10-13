import { Separator } from "@/components/separator";
import {
  useSelectedInvoiceProduct,
  useSelectedProductInvoiceQuery,
} from "@/features/invoice/selected-product";
import { ChevronDownIcon, XIcon } from "@/icons";
import { InventoryProductModel } from "@/models/inventory.model";

interface InvoiceCardProp {
  onClick?: () => void;
  product: InventoryProductModel;
  onRemove?: () => void;
}

export const InvoiceCard = ({ product, onRemove }: InvoiceCardProp) => {
  const { updateInvoiceQuantityByKey, updateInvoiceUnitPriceByKey } =
    useSelectedInvoiceProduct();
  const { data: selelctedInvoice } = useSelectedProductInvoiceQuery();

  // console.log(selelctedInvoice);

  return (
    <div className="p-5 border shadow-lg rounded-lg h-fit w-full max-w-[30rem] text-xs">
      <div className="flex gap-2 items-center text-xs justify-between">
        <div className="flex gap-2 items-center">
          <div className="w-2 h-2 bg-orange-300 rounded-full" />
          <span>{product.product.productName}</span>
          <span>{product.brand.brandName}</span>
          <span>{product.variant.variantName}</span>
        </div>
        <div
          onClick={onRemove}
          className="cursor-pointer hover:bg-gray-200 rounded p-1"
        >
          <XIcon />
        </div>
      </div>

      <Separator orientation="horizontal" />

      <div className="flex flex-col gap-3">
        <div className="flex items-center justify-between">
          <span>quantity</span>
          <ChevronDownIcon />
        </div>

        <div className="flex flex-col">
          <span>batch #</span>
          <div className="flex flex-col gap-2">
            <div className="flex">
              <input
                placeholder="20"
                className="drop-shadow-none rounded-r-none bg-gray-bg w-full"
                onChange={(e) =>
                  updateInvoiceQuantityByKey(
                    product.product.product_ID,
                    Number(e.target.value),
                    product.variant.variantName
                  )
                }
              />
              <select
                className="drop-shadow-none rounded-l-none border-l-black border-l bg-gray-bg w-full rounded-r-lg pl-3"
                value={"Select unit"}
              >
                <option value={"Boxes"}>Boxes</option>
                <option value={"Pieces"}>Pieces</option>
              </select>
            </div>
            {/* <span>not enough stock in batch</span> */}
          </div>
        </div>

        {/* <div className="flex flex-col">
          <span>auto restock</span>
          <div className="flex flex-col gap-2">
            <div className="flex">
              <input
                placeholder="20"
                className="drop-shadow-none rounded-r-none bg-gray-bg"
              />
              <input
                placeholder="boxes"
                className="drop-shadow-none rounded-l-none border-l-black border-l bg-gray-bg"
              />
            </div>
          </div>
        </div> */}

        <div className="flex gap-2 items-center justify-between">
          <div className="flex gap-2">
            <span>item price</span>
          </div>
          <XIcon />
        </div>

        <div className="flex flex-col">
          <span>pricing</span>
          <div className="flex flex-col gap-2">
            <div className="flex">
              <input
                placeholder="20"
                className="drop-shadow-none rounded-r-none bg-gray-bg"
                onChange={(e) =>
                  updateInvoiceUnitPriceByKey(
                    product.product.product_ID,
                    Number(e.target.value),
                    product.variant.variantName
                  )
                }
              />
              <input
                placeholder="boxes"
                className="drop-shadow-none rounded-l-none border-l-black border-l bg-gray-bg"
              />
            </div>
          </div>
        </div>

        <div className="flex flex-col">
          <span>discount</span>
          <div className="flex flex-col gap-2">
            <div className="flex">
              <input
                placeholder="20"
                className="drop-shadow-none rounded-r-none bg-gray-bg"
              />
              <input
                placeholder="boxes"
                className="drop-shadow-none rounded-l-none border-l-black border-l bg-gray-bg"
              />
            </div>
          </div>
        </div>

        <Separator orientation="horizontal" />

        <div className="flex gap-2">
          <span>total:</span>
          <span>P 0000.00</span>
        </div>
      </div>
    </div>
  );
};
