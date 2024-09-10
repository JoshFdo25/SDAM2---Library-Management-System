class Member
{
    public string Name { get; set; }
    public int MembershipId { get; set; }

    public Member(string name, int membershipId)
    {
        Name = name;
        MembershipId = membershipId;
    }
}
