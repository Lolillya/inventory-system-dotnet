import { Separator } from "@/components/separator";
import { ChevronDownIcon, XIcon } from "@/icons";
import { InventoryProductModel } from "@/models/inventory.model";

interface InvoiceCardProp {
  onClick?: () => void;
  product: InventoryProductModel;
}

export const InvoiceCard = ({ product }: InvoiceCardProp) => {
  return (
    <div className="p-5 border shadow-lg rounded-lg h-fit">
      <div className="flex gap-2 items-center text-xs justify-between">
        <div className="flex gap-2 items-center">
          <div className="w-2 h-2 bg-orange-300 rounded-full" />
          <span>{product.product.productName}</span>
          <span>{product.brand.brandName}</span>
          <span>{product.variant.variantName}</span>
        </div>
        <XIcon />
      </div>

      <Separator orientation="horizontal" />

      <div className="flex flex-col">
        <div className="flex items-center justify-between">
          <span>quantity</span>
          <ChevronDownIcon />
        </div>

        <div className="flex flex-col">
          <span>batch #</span>
          <div className="flex flex-col gap-2">
            <div className="flex">
              <input placeholder="20" className="drop-shadow-none rounded-r-none bg-gray-bg" />
              <input
                placeholder="boxes"
                className="drop-shadow-none rounded-l-none border-l-black border-l bg-gray-bg"
              />
            </div>
            <span>not enough stock in batch</span>
          </div>
        </div>

        <div className="flex flex-col">
          <span>auto restock</span>
          <div className="flex flex-col gap-2">
            <div className="flex">
              <input placeholder="20" className="drop-shadow-none rounded-r-none bg-gray-bg" />
              <input
                placeholder="boxes"
                className="drop-shadow-none rounded-l-none border-l-black border-l bg-gray-bg"
              />
            </div>
          </div>
        </div>

        <div className="flex gap-2 items-center text-xs justify-between">
          <div className="flex gap-2">
            <span>item price</span>
          </div>
          <XIcon />
        </div>

        <div className="flex flex-col">
          <span>pricing</span>
          <div className="flex flex-col gap-2">
            <div className="flex">
              <input placeholder="20" className="drop-shadow-none rounded-r-none bg-gray-bg" />
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
              <input placeholder="20" className="drop-shadow-none rounded-r-none bg-gray-bg" />
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
