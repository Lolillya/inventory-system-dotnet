import { MousePointerClickIcon } from "../icons";

export const NoSelectedState = () => {
  return (
    <span className="text-saltbox-gray flex flex-col items-center  justify-center w-full">
      <MousePointerClickIcon width={300} height={300} />
      <span>Search and select an item to view its details.</span>
    </span>
  );
};
