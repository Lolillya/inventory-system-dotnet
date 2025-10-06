export const InvoiceTable = () => {
  return (
    <div className="flex-1 flex flex-col overflow-hidden gap-2">
      {/* TABLE DATA HEADERS */}
      <div className="flex justify-between py-3 px-5 bg-custom-gray rounded-lg">
        <label className="text-left">Item</label>
        <label className="text-left">Quantity</label>
        <label className="text-left">Unit</label>
        <label className="text-right">Unit Price</label>
        <label className="text-right">Discount</label>
        <label className="text-right">Subtotal</label>
      </div>

      {/* TABLE DATA BODY */}
      <div className="overflow-auto flex flex-col h-full">
        {[...Array(20)].map((_, i) => (
          <div className="py-3 px-5 flex justify-between" key={i}>
            <span className="text-left">Item</span>
            <span className="text-left">99</span>
            <span className="text-left">Boxed</span>
            <span className="text-right">P 0000.00</span>
            <span className="text-right">0%</span>
            <span className="text-right">P 0000.00</span>
          </div>
        ))}
      </div>

      <span className="text-vesper-gray text-xs">
        Note: This order includes more than 10 items. We'll move the additional
        items to new invoices accordingly.
      </span>

      <div className="flex justify-between">
        <div className="flex flex-col">
          <div className="flex gap-2  text-sm tracking-wider">
            <span className="text-vesper-gray">P 0000.00</span>
            <label className="text-vesper-gray ">Discount</label>
          </div>

          <div className="flex gap-2 font-bold tracking-wider">
            <span>TOTAL: </span>
            <label>P 0000.00</label>
          </div>
        </div>

        <button>Save</button>
      </div>
    </div>
  );
};
