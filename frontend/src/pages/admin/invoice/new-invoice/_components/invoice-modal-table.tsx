export const InvoiceTable = () => {
  return (
    <div className="flex-1 flex flex-col overflow-hidden rounded-lg border">
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
    </div>
  );
};
