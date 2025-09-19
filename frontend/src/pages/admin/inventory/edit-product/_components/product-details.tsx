export const ProductDetails = () => {
  return (
    <>
      <div className="flex justify-between gap-5">
        <div className="flex flex-col w-full gap-3">
          <label>item *</label>
          <input type="text" placeholder="item name" />
        </div>

        <div className="flex flex-col w-full gap-3">
          <label>brand *</label>
          <input type="text" placeholder="item name" />
        </div>

        <div className="flex flex-col w-full gap-3">
          <label>category *</label>
          <input type="text" placeholder="item name" />
        </div>
      </div>

      <textarea placeholder="item description" className="bg-gray-bg rounded-lg border shadow-lg" rows={4} />
    </>
  );
};
