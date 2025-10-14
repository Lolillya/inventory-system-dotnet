type SeparatorProps = {
  orientation?: "horizontal" | "vertical";
  className?: string;
};

export const Separator = ({ orientation = "horizontal", className = "" }: SeparatorProps) => {
  const base = "border-gray";
  const horizontal = "border-t w-full my-1";
  const vertical = "border-l-2 flex-1 mx-1";
  const classes = `${base} ${orientation === "vertical" ? vertical : horizontal} ${className}`.trim();
  return <div className={classes}></div>;
};
