import { BoxIcon } from "../../../../icons";

export const SuppliersCard = () => {
  return (
    <div className="rounded-lg shadow-lg p-4 flex items-center gap-5 h-24 w-full justify-between border">
      <div className="flex flex-col">
        <span className="   capitalize">suppliers</span>
        <span className="text-xl font-bold">15</span>
      </div>

      <div className="rounded-lg bg-purple-bg p-3">
        <div className="text-purple-fill">
          <BoxIcon />
        </div>
      </div>
    </div>
  );
};
