import { StarIcon, TrashIcon } from "../icons";
import { SupplierModel } from "../models/supplier.model";
import { useSetSupplierSelected } from "../queryOptions/suppliers/supplier-selected.query";

export const InfoCard = (data: SupplierModel) => {
  const setSupplierSelected = useSetSupplierSelected();

  const handleClick = (supplier: SupplierModel) => {
    console.log("Clicked supplier:", supplier);
    setSupplierSelected(supplier);
  };

  return (
    <div
      className="hover:bg-custom-gray-lighter hover:cursor-pointer p-5 rounded-lg flex items-center justify-between"
      onClick={() => handleClick(data)}
    >
      <div className="flex items-center gap-5">
        <div className="bg-black h-11 w-11 rounded-lg"></div>

        <div className="flex flex-col">
          <span className="info-name">{data.companyName}</span>
          <span className="info-id">{data.id}</span>
        </div>
      </div>

      <div className="flex items-center gap-1">
        <div className="info-card-actions rounded-lg hover:bg-tinker-yellow hover:text-laughing-orange transition-all duration-300 ">
          <StarIcon width={24} height={24} />
        </div>
        <div className="info-card-actions rounded-lg hover:bg-cake-pink hover:text-munch-pink transition-all duration-300">
          <TrashIcon width={24} height={24} />
        </div>
      </div>
    </div>
  );
};
