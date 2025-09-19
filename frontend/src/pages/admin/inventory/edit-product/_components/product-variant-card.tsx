import { PlusIcon, XIcon } from "../../../../../icons";

export const ProductVariantCard = () => {
  return (
    <div className="flex flex-col flex-1 gap-3">
      <label>variants *</label>
      <div>
        <div className="flex bg-gray-bg p-3 rounded-lg border shadow-lg gap-5 items-center">
          <span className="w-full bg-white p-2 rounded-lg">variant</span>

          <div className="bg-white flex items-center pl-2 rounded-lg w-3/12 gap-5">
            <div className="w-2 h-2 bg-orange-400 rounded-full" />
            <input type="text" className="drop-shadow-none" placeholder="1000" />
          </div>

          <div className="bg-white flex items-center pl-2 rounded-lg w-3/12 gap-5">
            <div className="w-2 h-2 bg-red-400 rounded-full" />
            <input type="text" className="drop-shadow-none" placeholder="1000" />
          </div>

          <div>
            <XIcon />
          </div>
        </div>
      </div>
    </div>
  );
};
