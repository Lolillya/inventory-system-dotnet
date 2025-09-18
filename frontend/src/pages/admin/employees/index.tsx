import React from "react";
import { InfoCard } from "../../../components/info-card";
import { NoSelectedState } from "../../../components/no-selected-state";
import { SelectedUser } from "../../../components/selected-user";
import { Separator } from "../../../components/separator";
import { FilterIcon, PlusIcon, SearchIcon } from "../../../icons";
import { userEmployeesQuery } from "../../../features/employees/employee-get-all.query";
import { useSelectedEmployeeQuery } from "../../../features/employees/empployee-selected.query";

const EmployeesPage = () => {
  const { data: employees, isLoading, error } = userEmployeesQuery();
  const { data: selectedEmployee } = useSelectedEmployeeQuery();

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
            {employees?.map((data, index) => (
              <React.Fragment key={data.id}>
                <InfoCard type="employee" key={index} {...data} />
                <Separator />
              </React.Fragment>
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
            {!selectedEmployee ? (
              <NoSelectedState />
            ) : (
              <SelectedUser type="employee" {...selectedEmployee} />
            )}
          </div>
        </div>
      </div>
    </section>
  );
};

export default EmployeesPage;
