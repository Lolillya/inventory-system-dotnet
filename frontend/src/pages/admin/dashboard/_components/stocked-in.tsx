import { UpArrowIcon, DownArrowIcon } from "../../../../icons";

export const StockedIn = () => {
  return (
    <div className="rounded-lg shadow-lg p-5 flex items-center gap-5">
      <div className="flex flex-col">
        <div className="flex gap-2">
          <span className="capitalize">stocked in</span>
          <div className="flex gap-0.5 items-center">
            <span className="text-green-fill">
              <UpArrowIcon width={16} height={16} />
            </span>

            <span className="text-xs text-green-fill">4%</span>
          </div>
        </div>
        <span className="text-xl font-bold">4,200</span>
      </div>

      <div className="rounded-lg bg-blue-bg p-3">
        <div className="text-blue-fill">
          <DownArrowIcon />
        </div>
      </div>
    </div>
  );
};
