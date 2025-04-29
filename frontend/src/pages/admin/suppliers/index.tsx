import { InfoCard } from "../../../components/info-card";
import { FilterIcon, PlusIcon, SearchIcon } from "../../../icons";
import { useSuppliersQuery } from "../../../queryOptions/suppliers/supplier-get-all.query";
import { useSupplierSelectedQuery } from "../../../queryOptions/suppliers/supplier-selected.query";
import { Separator } from "../../../components/separator";
import { NoSelectedState } from "../../../components/no-selected-state";
import { SelectedUser } from "../../../components/selected-user";


const SuppliersPage = () => {
  const { data: suppliers, isLoading, error } = useSuppliersQuery();
  const { data: selectedSupplier } = useSupplierSelectedQuery();

  // FETCH DATA LOADING STATE
  if (isLoading) return <div>Loading...</div>;
  // FETCHING DATA ERROR STATE
  if (error) return <div>Error...</div>;
  return (
    <section>
      <div className="w-full mb-8">
        <div className="flex items-center justify-between w-full">
          <div className="flex items-center gap-3 max-w-lg w-full shrink-0">
            <div className="relative w-full">
              <input placeholder="Search..." className="input-style-2" />
              <i className="absolute left-3 top-1/2 -translate-y-1/2 text-gray-400">
                <SearchIcon />
              </i>
            </div>

            <div className="p-3 bg-custom-gray rounded-lg">
              <FilterIcon />
            </div>
          </div>
          <button className="flex items-center justify-center gap-2">
            <PlusIcon />
            new supplier
          </button>
        </div>
      </div>

      <div className="flex flex-1 gap-3 overflow-y-hidden">
        {/*  LEFT PANEL */}
        <div className="w-full flex flex-col gap-3">
          <div className="bg-custom-gray p-3 rounded-lg gap-10 flex items-center">
            <label className="capitalize text-saltbox-gray font-normal text-lg">
              suppiers
            </label>
            <span className="capitalize text-vesper-gray"># records</span>
          </div>

          <div className="w-full overflow-y-scroll">
            {suppliers?.map((data, index) => (
              <>
                <InfoCard type="supplier" key={index} {...data} />
                <Separator />
              </>
            ))}
          </div>
        </div>

        {/* RIGHT PANEL */}
        <div className="w-[70%] flex flex-col gap-3">
          <div className="bg-custom-gray p-3 rounded-lg gap-10 flex items-center">
            <label className="capitalize text-saltbox-gray font-normal text-lg">
              details
            </label>
          </div>

          <div className="h-full bg-custom-gray rounded-lg flex">
            {!selectedSupplier ? (
              <NoSelectedState />
            ) : (
              <SelectedUser type="supplier" {...selectedSupplier} />
            )}
          </div>
        </div>
      </div>
    </section>
  );
};

export default SuppliersPage;
