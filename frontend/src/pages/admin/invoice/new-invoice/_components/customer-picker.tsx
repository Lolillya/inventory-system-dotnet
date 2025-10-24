import { useCustomersQuery } from "@/features/customers/customer-get-all.query";
import {
  useSelectedCustomerQuery,
  useSetCustomerSelected,
} from "@/features/customers/customer-selecter.query";
import { useState, useRef, useEffect } from "react";

type CustomerPickerProps = {
  customersData?: any[];
  placeholder?: string;
};

export const CustomerPicker = ({
  customersData,
  placeholder,
}: CustomerPickerProps) => {
  const [open, setOpen] = useState(false);
  const [query, setQuery] = useState("");

  const ref = useRef<HTMLDivElement | null>(null);

  // if customersData not provided, fall back to query hook
  const { data: fetchedCustomers } = useCustomersQuery();
  const { UPDATE_SELECTED_CUSTOMER } = useSetCustomerSelected();
  const { data: selectedCustomer } = useSelectedCustomerQuery();
  const list = customersData ?? fetchedCustomers ?? [];

  useEffect(() => {
    const onClick = (e: MouseEvent) => {
      if (!ref.current) return;
      if (!ref.current.contains(e.target as Node)) setOpen(false);
    };
    window.addEventListener("click", onClick);
    return () => window.removeEventListener("click", onClick);
  }, []);

  const filtered = list?.filter((c) =>
    String(c.companyName).toLowerCase().includes(query.toLowerCase())
  );

  return (
    <div className="flex flex-col w-full gap-2 relative" ref={ref}>
      <label className="text-vesper-gray">Customer</label>
      <div className="flex w-full">
        <input
          className="w-full"
          placeholder={placeholder ?? "Customer Name"}
          value={selectedCustomer?.companyName ?? ""}
          onFocus={() => setOpen(true)}
          onChange={(e) => {
            setQuery(e.target.value);
            setOpen(true);
          }}
        />
      </div>

      {open && (
        <div className="absolute w-full bg-white top-20 max-h-64 overflow-y-auto border shadow-lg rounded-lg p-3">
          {filtered && filtered.length > 0 ? (
            filtered.map((customer, index) => (
              <div
                key={index}
                className="p-2 hover:bg-gray-100 rounded-lg cursor-pointer"
                onClick={() => {
                  setQuery("");
                  setOpen(false);
                  UPDATE_SELECTED_CUSTOMER(customer);
                }}
              >
                <div className="font-semibold">{customer.companyName}</div>
                <div className="text-xs text-vesper-gray">{customer.email}</div>
              </div>
            ))
          ) : (
            <div className="text-vesper-gray">No customers found</div>
          )}
        </div>
      )}
    </div>
  );
};
