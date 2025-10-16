import { Separator } from "@/components/separator";
import { useSelectedRestock } from "@/features/restock/selected-restock";
import { PlusIcon, RightArrowIcon, XIcon } from "@/icons";
import { units } from "@/models/enum";
import { InventoryProductModel } from "@/models/inventory.model";

interface RestockCardProp {
  onClick?: () => void;
  product: InventoryProductModel;
  onRemove?: () => void;
}

const RestockCard = ({ product, onRemove }: RestockCardProp) => {
  const {
    UPDATE_RESTOCK_QUANTITY,
    UPDATE_RESTOCK_UNIT_PRICE,
    UPDATE_RESTOCK_UNIT,
  } = useSelectedRestock();

  return (
    <div className="p-5 border shadow-lg rounded-lg h-fit w-full max-w-[30rem] text-xs">
      <div className="flex gap-2 items-center text-xs justify-between">
        <div>
          <span>{product.product.productName}</span>
          <span>-</span>
          <span>{product.brand.brandName}</span>
          <span>-</span>
          <span>{product.variant.variantName}</span>
        </div>

        <div
          className="cursor-pointer hover:bg-gray-200 rounded p-1"
          onClick={onRemove}
        >
          <XIcon />
        </div>
      </div>

      <Separator orientation="horizontal" />

      <div className="flex gap-1">
        <div className="flex flex-col gap-1">
          <label>stock</label>
          <input
            placeholder="qty"
            className="w-full drop-shadow-none bg-custom-gray"
            onChange={(e) =>
              UPDATE_RESTOCK_QUANTITY(
                product.product.product_ID,
                Number(e.target.value),
                product.variant.variantName
              )
            }
          />
        </div>

        <div className="flex flex-col gap-1">
          <label>price</label>
          <input
            placeholder="0.00"
            className="w-full drop-shadow-none bg-custom-gray"
            onChange={(e) =>
              UPDATE_RESTOCK_UNIT_PRICE(
                product.product.product_ID,
                Number(e.target.value),
                product.variant.variantName
              )
            }
          />
        </div>

        <div className="flex flex-col gap-1">
          <label>unit</label>
          <select
            className="rounded-lg w-full p-3 text-sm drop-shadow-none bg-custom-bg-white"
            value={units.NONE}
            onChange={(e) =>
              UPDATE_RESTOCK_UNIT(
                product.product.product_ID,
                e.target.value as units,
                product.variant.variantName
              )
            }
          >
            <option value={units.BOXES}>Boxes</option>
            <option value={units.PACKS}>Packs</option>
          </select>
        </div>
      </div>

      <Separator orientation="horizontal" />

      <div className="flex gap-1">
        <div className="flex flex-col gap-1 w-2/6">
          <label>stock</label>
          <input
            placeholder="qty"
            className="w-full drop-shadow-none bg-custom-bg-white"
          />
        </div>

        <div className="flex flex-col gap-1 w-2/6">
          <label>price</label>
          <input
            placeholder="0.00"
            className="w-full drop-shadow-none bg-custom-bg-white"
          />
        </div>

        <div className="flex flex-col gap-1 w-full">
          <label>unit conversion</label>
          <div className="flex gap-1 items-center w-full">
            <select className="rounded-lg w-2/4 p-3 text-sm drop-shadow-none bg-custom-bg-white">
              <option value={"Boxes"}>Boxes</option>
              <option value={"Pieces"}>Pieces</option>
            </select>
            <RightArrowIcon />

            <div className="flex w-full">
              <input
                placeholder="qty"
                className="w-3/6 rounded-r-none drop-shadow-none bg-custom-bg-white"
              />
              <select className="rounded-lg w-full p-3 text-sm rounded-l-none border-l-gray border-l drop-shadow-none bg-custom-bg-white">
                <option value={"Boxes"}>Boxes</option>
                <option value={"Pieces"}>Pieces</option>
              </select>
            </div>

            <div>
              <PlusIcon />
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default RestockCard;
