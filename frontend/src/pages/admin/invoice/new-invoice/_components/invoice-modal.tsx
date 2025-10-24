import { XIcon } from "@/icons";
import { InvoiceTable } from "./invoice-modal-table";
import { useCustomersQuery } from "@/features/customers/customer-get-all.query";
import { CustomerPicker } from "./customer-picker";

interface CreateInvoiceModalProps {
  createInvoice: () => void;
}

export const CreateInvoiceModal = ({
  createInvoice,
}: CreateInvoiceModalProps) => {
  const { data: customersData } = useCustomersQuery();

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
            <div onClick={createInvoice}>
              <XIcon />
            </div>
          </div>

          {/* SEARCH CONTAINER */}
          <CustomerPicker customersData={customersData} />

          {/* TABLE CONTAINER */}
          <InvoiceTable />
        </div>
      </div>
    </div>
  );
};
