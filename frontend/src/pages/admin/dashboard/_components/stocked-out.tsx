import { UpArrowsIcon, DownArrowDashedIcon, DownArrowsIcon } from "../../../../icons";

export const StockedOut = () => {
  return (
    <div className="rounded-lg shadow-lg p-5 flex items-center gap-5 h-24 w-full justify-between border">
      <div className="flex flex-col">
        <div className="flex gap-2">
          <span className="capitalize">stocked out</span>
          <div className="flex gap-0.5 items-center">
            <span className="text-red-fill">
              <DownArrowsIcon width={16} height={16} />
            </span>

            <span className="text-xs text-red-fill">4%</span>
          </div>
        </div>
        <span className="text-xl font-bold">4,200</span>
      </div>

      <div className="rounded-lg bg-blue-bg p-3">
        <div className="text-blue-fill">
          <DownArrowDashedIcon />
        </div>
      </div>
    </div>
  );
};
