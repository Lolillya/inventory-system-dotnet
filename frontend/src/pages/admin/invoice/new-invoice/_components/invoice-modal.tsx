import { XIcon } from "@/icons";
import { InvoiceTable } from "./invoice-modal-table";

export const CreateInvoiceModal = () => {
  return (
    <div className="absolute bg-black/40 w-full h-full top-0 left-0 flex justify-center items-center z-50">
      <div className="w-3/6 h-4/5 bg-white px-20 py-10 rounded-lg border shadow-lg">
        <div className="flex flex-col gap-5 flex-1 h-full">
          {/* HEADER */}
          <div className="flex items-center justify-between w-full">
            <div className="flex items-center gap-2">
              <h2>Order Confirmation</h2>
              <span className="text-vesper-gray text-lg tracking-wider">
                #000000
              </span>
            </div>
            <XIcon />
          </div>

          {/* SEARCH CONTAINER */}
          <div className="flex flex-col w-full gap-2">
            <label className="text-vesper-gray">Customer & Term</label>
            <div className="flex w-full">
              <input className="w-full rounded-r-none" />
              <input className="w-2/12 rounded-l-none" />
            </div>
          </div>

          {/* TABLE CONTAINER */}
          <InvoiceTable />
        </div>
      </div>
    </div>
  );
};
