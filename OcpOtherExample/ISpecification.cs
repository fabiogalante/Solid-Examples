namespace OcpOtherExample
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }


    /*
     * With the ISpecification interface, we can determine whether or not our criterion is
     * satisfied and we can send it to the Filter
     * method from the IFilter interface.
     */
}
