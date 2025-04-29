import { Separator } from "./separator";
import {
  EditIcon,
  MailIcon,
  PhoneIcon,
  PinIcon,
  RightUpArrowIcon,
  UserIcon,
} from "../icons";
import { UserClientModel } from "../models/user-client.model";

type UserType = "customer" | "supplier" | "employee";

interface SelectedUserProps extends UserClientModel {
  type: UserType;
}

export const SelectedUser = ({ type, ...user }: SelectedUserProps) => {
  return (
    <div className="flex flex-col p-5 w-full gap-2">
      <div className="flex items-center justify-between">
        <div className="flex items-center gap-5">
          <div className="h-16 w-16 !rounded-lg">
            <div className="bg-black h-16 w-16 rounded-lg"></div>
          </div>
          <div className="flex flex-col gap-2">
            <div className="flex items-center gap-2">
              <p className="text-base text-slate-700">{user.companyName}</p>

              <span className="rounded-full bg-cyan-200 px-2 py-[3px] text-sm tracking-wide text-cyan-700">
                {type}
              </span>
            </div>
            <p className="text-sm text-slate-400">{user.id}</p>
          </div>
        </div>
        <div className="cursor-pointer hover:bg-bellflower-gray p-3 rounded-lg transition-colors duration-300 text-vesper-gray">
          <EditIcon />
        </div>
      </div>

      <Separator />

      {/* user FULLNAME SECTION */}
      <div className="p-2 rounded-lg bg-wash-gray">
        <div className="p-2 flex items-center gap-3">
          <div className="bg-bellflower-gray h-12 w-12 rounded-lg flex items-center justify-center text-blouse-gray">
            <UserIcon />
          </div>
          <div className="flex flex-col justify-center">
            <div className="flex items-center gap-2">
              <p className="text-base info-name">
                {user.firstName} {user.lastName}
              </p>
            </div>
            <p className="info-id">Representative</p>
          </div>
        </div>
      </div>

      {/* user CONTACT NUMBER SECTION */}
      <div className="p-2 rounded-lg bg-wash-gray">
        <div className="p-2 flex items-center gap-3">
          <div className="bg-bellflower-gray h-12 w-12 rounded-lg flex items-center justify-center text-blouse-gray">
            <PhoneIcon />
          </div>
          <div className="flex flex-col justify-center">
            <div className="flex items-center gap-2">
              <p className="text-base info-name">{user.phoneNumber}</p>
            </div>
            <p className="text-sm info-id">Contact</p>
          </div>
        </div>
      </div>

      {/* user EMAIL SECTION */}
      <div className="p-2 rounded-lg bg-wash-gray">
        <div className="p-2 flex items-center gap-3">
          <div className="bg-bellflower-gray h-12 w-12 rounded-lg flex items-center justify-center text-blouse-gray">
            <MailIcon />
          </div>
          <div className="flex flex-col justify-center">
            <div className="flex items-center gap-2">
              <p className="text-base info-name">{user.email}</p>
            </div>
            <p className="text-sm info-id">Email</p>
          </div>
        </div>
      </div>

      {/* user ADDRESS SECTOIN */}
      <div className="p-2 rounded-lg bg-wash-gray">
        <div className="p-2 flex gap-3">
          <div className="bg-bellflower-gray h-12 w-12 rounded-lg flex items-center justify-center text-blouse-gray">
            <PinIcon />
          </div>
          <div className="flex flex-col justify-center gap-2">
            <div className="flex flex-col">
              <span className="text-sm info-name">123 Main St.</span>
              <span className="text-sm info-name">New York</span>
              <span className="text-sm info-name">NY</span>
              <span className="text-sm info-name">USA</span>
              <span className="text-sm info-name">10001</span>
            </div>
            <p className="text-sm info-id">Address</p>
          </div>
        </div>
      </div>

      {/* user NOTES SECTION */}
      <div className="p-2 rounded-lg bg-wash-gray">
        <div className="p-2 flex gap-3 flex-col">
          <p className="text-sm text-slate-400">Notes</p>
          <div className="flex w-full gap-2">
            <textarea
              rows={3}
              value={user.notes}
              className="w-full resize-none text-sm"
            />
          </div>
        </div>
      </div>

      {/* RESTOCKS SECTION */}
      <div className="p-2 rounded-lg bg-wash-gray flex shrink-0 flex-1 flex-col">
        <div className="p-2 flex gap-3 flex-col">
          <button className="bg-transparent text-vesper-gray font-semibold tracking-wide w-fit hover:bg-bellflower-gray">
            Restocks
            <RightUpArrowIcon width={16} height={16} />
          </button>
          <div className="flex w-full gap-2"></div>
        </div>

        <div className="w-full h-full flex items-center justify-center">
          <span className="font-semibold info-name">No restock found</span>
        </div>
      </div>
    </div>
  );
};
